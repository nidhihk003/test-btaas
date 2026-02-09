import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class UserController_test {
    @Test
    void getUserWithValidId() {
        assertEquals(User data for id 1, new UserController().getUser(1));
    }
    @Test
    void getUserWithNonExistentId() {
        assertEquals(User not found, new UserController().getUser(999));
    }
    @Test
    void getUserWithNegativeId() {
        assertEquals(Invalid user id, new UserController().getUser(-1));
    }
    @Test
    void getUserWithZeroId() {
        assertEquals(Invalid user id, new UserController().getUser(0));
    }
    @Test
    void getUserWithLargeId() {
        assertEquals(User data for id 2147483647, new UserController().getUser(2147483647));
    }
    @Test
    void getUserWithSmallId() {
        assertEquals(User data for id 1, new UserController().getUser(1));
    }
    @Test
    void getUserWithNullId() {
        assertEquals(Invalid user id, new UserController().getUser(null));
    }
    @Test
    void getUserWithNonNumericId() {
        assertEquals(Invalid user id, new UserController().getUser("abc"));
    }
    @Test
    void getUserWithBoundaryId() {
        assertEquals(User data for id 1, new UserController().getUser(1));
    }
    @Test
    void getUserWithMaxIntId() {
        assertEquals(User data for id 2147483647, new UserController().getUser(Integer.MAX_VALUE));
    }
}