import axios from "axios";
import { validateUser } from "./validator.js";
import { API_URL } from "./config.js";

export async function fetchUser(id) {
  const res = await axios.get(`${API_URL}/users/${id}`);
  if (!validateUser(res.data)) throw new Error("Invalid");
  return res.data;
}
