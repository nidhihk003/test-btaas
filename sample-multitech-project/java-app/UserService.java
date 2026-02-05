private final UserRepository repo = new UserRepository();

public String getUser(int id){
   return repo.findUser(id);
}
