# Concat_Addin

This is a simple VSTO Excel add-in that allows data in a range to be concatenated.  The add-in can do the following:

* Wrap text in apostrophes or any other user specified character e.g. Banana,Apple becomes 'Apple','Banana'.   This is useful when that data is to be used in a SQL statement, for exmample
* Eliminate duplicate values
* Concatenate strings together with any character (defaults to comma)
* Transform text to upper or lower case
* Sort ascending or descending
* Apply line feed characters after each item so that each item appears on its own row

The add-in is fast and can easily handle tens of thousands of values.  It has been tested on ranges containing 200,000 values.

![image](https://user-images.githubusercontent.com/10345958/132425628-da33c158-0b25-4d7c-a1ce-5e8dca82f5ef.png)

![image](https://user-images.githubusercontent.com/10345958/132425706-ed57a58e-b3ac-44e5-9428-a76998409287.png)


