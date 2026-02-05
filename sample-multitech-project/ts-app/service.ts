import { User } from "./models";

export function getUser(id: number): User {
  return {
    id,
    name: "Dummy TS User"
  };
}
