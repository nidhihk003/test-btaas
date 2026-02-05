import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/users")
public class UserController {

    private final UserService service = new UserService();

    @GetMapping("/{id}")
    public String getUser(@PathVariable int id) {
        return service.getUser(id);
    }
}
