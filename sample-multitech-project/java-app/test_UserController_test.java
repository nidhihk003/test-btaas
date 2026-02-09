import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class UserController_test {
    @Test
    void getUserValidId() {
        assertEquals(User with ID 1, new UserController().getUser(1));
    }
    @Test
    void getUserNegativeId() {
        assertEquals(Error: Invalid ID, new UserController().getUser(-1));
    }
    @Test
    void getUserZeroId() {
        assertEquals(Error: Invalid ID, new UserController().getUser(0));
    }
    @Test
    void getUserHighId() {
        assertEquals(User with ID 999999, new UserController().getUser(999999));
    }
    @Test
    void getUserNonExistentId() {
        assertEquals(Error: User not found, new UserController().getUser(999999999));
    }
    @Test
    void getUserStringInsteadOfId() {
        assertEquals(Error: Invalid ID, new UserController().getUser(Integer.parseInt("abc")));
    }
    @Test
    void getUserSpecialCharId() {
        assertEquals(Error: Invalid ID, new UserController().getUser(Integer.parseInt("@#$%")));
    }
    @Test
    void getUserNullId() {
        assertEquals(Error: Invalid ID, new UserController().getUser(null));
    }
    @Test
    void getUserBoundaryMinIntId() {
        assertEquals(Error: Invalid ID, new UserController().getUser(Integer.MIN_VALUE));
    }
    @Test
    void getUserBoundaryMaxIntId() {
        assertEquals(User with ID 2147483647, new UserController().getUser(Integer.MAX_VALUE));
    }
}