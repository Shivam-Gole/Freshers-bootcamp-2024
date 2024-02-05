Test Specification ---

1. Given -> ""
   When  ->  Add function
   Then -> return 0;

2. Given -> "1"
   When  -> 
   Then -> return 0;

3. Given -> "1"
   When  -> 
   Then -> return 1;

4. Given -> "1,2"
   When  -> Add is called
   Then -> return 3;

5. Given -> "1,-2"
   When  -> Add is called
   Then -> Exception;

6. Given -> "1\n2,3"
   When  -> Add is called
   Then -> return 6;

7. Given -> "1001,1"
   When  -> Add
   Then -> return 1;

8. Given -> "//;\n1;2"
   When -> Add
   Then -> return 3;

9. Given -> "//[***]\n1***2***3"
   When  -> Add is called
   Then  -> return 6;
