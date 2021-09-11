# Concat Add-in for Excel

This is a simple VSTO Excel add-in that allows data in a range to be concatenated.  The add-in can do the following:

* Wrap text in apostrophes or any other user specified character e.g. Banana,Apple becomes 'Apple','Banana'.   This is useful when that data is to be used as part of a SQL statement, for example
* Eliminate duplicate values
* Concatenate strings together with any character (defaults to comma)
* Transform text to upper or lower case
* Sort ascending or descending
* Apply line feed characters after each item so that each item appears on its own row

The add-in is fast and can easily handle tens of thousands of values.  It has been tested on ranges containing 200,000 values.

![image](https://user-images.githubusercontent.com/10345958/132937674-da86c320-15d0-440f-ae44-82275858aef1.png)

![image](https://user-images.githubusercontent.com/10345958/132937696-1c32d716-0259-40e7-8560-29723e025295.png)



