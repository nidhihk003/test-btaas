import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class UserRepository_test {
    @Test
    void findUserWithPositiveId() {
        assertEquals(User 1, findUser(1));
    }
    @Test
    void findUserWithZeroId() {
        assertEquals(User 0, findUser(0));
    }
    @Test
    void findUserWithNegativeId() {
        assertEquals(User -1, findUser(-1));
    }
    @Test
    void findUserWithLargePositiveId() {
        assertEquals(User 1000000, findUser(1000000));
    }
    @Test
    void findUserWithLargeNegativeId() {
        assertEquals(User -1000000, findUser(-1000000));
    }
    @Test
    void findUserWithMaxIntId() {
        assertEquals(User 2147483647, findUser(2147483647));
    }
    @Test
    void findUserWithMinIntId() {
        assertEquals(User -2147483648, findUser(-2147483648));
    }
    @Test
    void findUserWithSingleDigitId() {
        assertEquals(User 5, findUser(5));
    }
    @Test
    void findUserWithDoubleDigitId() {
        assertEquals(User 99, findUser(99));
    }
    @Test
    void findUserWithTripleDigitId() {
        assertEquals(User 123, findUser(123));
    }
}