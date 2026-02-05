import { User } from "./models";
import { findUser } from "./repository";


export function getUser(id: number): User {
  return {
    id,
    name: "Dummy TS User"
  };
}
