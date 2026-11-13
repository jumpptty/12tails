import { handleSlip } from "./handler.js";
import { handleDonors } from "./donors_live.js";
import { handleGuidePost, handleGuides, handlePreview } from "./guides.js";

const deps = { fetch };   // `fetch` is called unbound inside the handlers (workerd refuses another receiver)
export default {
  fetch(req, env){
    const { pathname } = new URL(req.url);
    if (pathname === "/slip") return handleSlip(req, env, deps);
    if (pathname === "/api/donors") return handleDonors(req, env, deps);
    if (pathname === "/guide") return handleGuidePost(req, env, deps);
    if (pathname === "/api/guides") return handleGuides(req, env, deps);
    if (pathname.startsWith("/g/")) return handlePreview(req, env, deps);
    return new Response(JSON.stringify({ ok: false, error: "not-found" }), { status: 404, headers: { "Content-Type": "application/json" } });
  },
};
