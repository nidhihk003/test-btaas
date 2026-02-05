import { validateUser } from "./validator.js";

export function fetchUser(id) {
  const user = { id, name: "Dummy JS User" };

  if (!validateUser(user)) {
    throw new Error("Invalid user");
  }

  return user;
}
