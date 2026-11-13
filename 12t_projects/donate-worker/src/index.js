import { handleSlip } from "./handler.js";
import { handleDonors } from "./donors_live.js";

const deps = { fetch };   // `fetch` is called unbound inside the handlers (workerd refuses another receiver)
export default {
  fetch(req, env){
    const { pathname } = new URL(req.url);
    if (pathname === "/slip") return handleSlip(req, env, deps);
    if (pathname === "/api/donors") return handleDonors(req, env, deps);
    return new Response(JSON.stringify({ ok: false, error: "not-found" }), { status: 404, headers: { "Content-Type": "application/json" } });
  },
};
