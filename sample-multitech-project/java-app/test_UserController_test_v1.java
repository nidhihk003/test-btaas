import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class UserController_test {
    @Test
    void getUserWithValidId() {
        assertEquals(User 1 details, new UserController().getUser(1));
    }
    @Test
    void getUserWithNonExistentId() {
        assertEquals(User not found, new UserController().getUser(9999));
    }
    @Test
    void getUserWithNegativeId() {
        assertEquals(Invalid user ID, new UserController().getUser(-1));
    }
    @Test
    void getUserWithZeroId() {
        assertEquals(Invalid user ID, new UserController().getUser(0));
    }
    @Test
    void getUserWithMaxIntegerId() {
        assertEquals(User MAX_INT details, new UserController().getUser(Integer.MAX_VALUE));
    }
    @Test
    void getUserWithMinIntegerId() {
        assertEquals(Invalid user ID, new UserController().getUser(Integer.MIN_VALUE));
    }
    @Test
    void getUserWithIdAsString() {
        assertEquals(NumberFormatException, new UserController().getUser(Integer.parseInt("abc")));
    }
    @Test
    void getUserWithNullId() {
        assertEquals(NullPointerException, new UserController().getUser(null));
    }
    @Test
    void getUserWithSpecialCharactersId() {
        assertEquals(NumberFormatException, new UserController().getUser(Integer.parseInt("@#$%")));
    }
    @Test
    void getUserWithFloatingPointId() {
        assertEquals(User 3 details, new UserController().getUser((int) 3.14));
    }
}