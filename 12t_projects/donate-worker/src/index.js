import { handleSlip } from "./handler.js";

export default { fetch: (req, env) => handleSlip(req, env, { fetch }) };
