import { User } from "./models";

export function findUser(id:number):User {
  return { id, name:"TS Repo User"};
}
