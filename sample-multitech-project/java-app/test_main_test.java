import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class main_test {
    @Test
    void addTwoPositiveNumbers() {
        assertEquals(15, Main.addNumbers(5, 10));
    }
    @Test
    void addPositiveAndNegativeNumber() {
        assertEquals(5, Main.addNumbers(10, -5));
    }
    @Test
    void addTwoNegativeNumbers() {
        assertEquals(-10, Main.addNumbers(-4, -6));
    }
    @Test
    void addNumberWithZeroFirst() {
        assertEquals(7, Main.addNumbers(0, 7));
    }
    @Test
    void addNumberWithZeroSecond() {
        assertEquals(7, Main.addNumbers(7, 0));
    }
    @Test
    void addLargePositiveNumbers() {
        assertEquals(3000000, Main.addNumbers(1000000, 2000000));
    }
    @Test
    void addLargeNegativeNumbers() {
        assertEquals(-3000000, Main.addNumbers(-1000000, -2000000));
    }
    @Test
    void addNumberWithZeroBoth() {
        assertEquals(0, Main.addNumbers(0, 0));
    }
    @Test
    void addMaxIntegerValues() {
        assertEquals(2147483646, Main.addNumbers(2147483647, -1));
    }
    @Test
    void addMinIntegerValues() {
        assertEquals(-2147483647, Main.addNumbers(-2147483648, 1));
    }
}