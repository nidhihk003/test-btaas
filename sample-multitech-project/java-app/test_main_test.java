import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class main_test {
    @Test
    void testAddNumbers() {
        assertEquals(5, Main.addNumbers(2, 3));
    }
}