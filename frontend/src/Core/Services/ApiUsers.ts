import type { User } from "../types/User";
import { BaseFetch } from "./BaseFetch";

// Add a new user
async function addUser(user: User) {
  console.log(user);
  return BaseFetch<null>("/Users", {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(user),
  });
}
export const usersApi = {
  addUser,
};
