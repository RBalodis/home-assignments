## ASP, HTML, CSS

### Make simplified version of patient registration funcionality in web page. Funcionality should contain:
 - adding new patient by doctor
 - view list with all patients
 - view list of doctor patients
#### Do all this using ASP, Angular, entity framework

## C# questions

1. What does the following C#.NET code snippet will print?
<pre> 
int i = 0, j = 0; 
label:
    i++;
    j+=i;
if (i < 10)
{
    Console.Write(i +" ");
    goto label; 
}
</pre>
<pre>
A. Prints 1 to 9
B. Prints 0 to 8
C. Prints 2 to 8
D. Prints 2 to 9
E. Compile error at label:.
</pre>

2. Which of the following is the correct output for the C#.NET program given below?
<pre>
int i = 20 ;
for( ; ; )
{
    Console.Write(i + " "); 
    if (i >= -10)
        i -= 4; 
    else 
        break;
}
</pre>

<pre>
A. 20 16 12 8 4 0 -4 -8
B. 20 16 12 8 4 0
C. 20 16 12 8 4 0 -4 -8 -12
D. 16 12 8 4 0
E. 16 8 0 -8
</pre>

3. What is the output?
<pre>
    static void Main (string [] args)
    {
        Char  c='a';
        int j=c;
        Console.WriteLine (j);
        Console.ReadLine ();
    }
</pre>

4.  Can I assign 1 or 0 into bool variable?
<pre>
    static void Main(string[] args)
    { 
        bool b = 1;
        Console.WriteLine(b);
        Console.ReadLine();
    }
</pre>

5. What is the output ?
<pre>
    static void Main(string[] args)
    { 
    bool b =true;
    Console.WriteLine(b);
    Console.ReadLine();
    }
</pre>

6. What is the difference between GetType() and typeof()?    (Yes/No)

|                                                       | **typeof()** | **GetType()** |
| ----------------------------------------------------- | ------------ | ------------- |
| It will return the given data type base type.         |              |               |
| It will return the given variabledata type base type. |              |               |
| It is a operator                                      |              |               |
| It is a method                                        |              |               |	

7. What is the output?
<pre>
    static void Main(string[] args)
    {
    var  a = 10;
    var  b = 10.5;
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.ReadLine();
    }
</pre>

8.   Difference between dll and exe?  (Yes/No)

|                                       | **exe** | **dll** |
| ------------------------------------- | ------- | ------- |
| Stands for executable                 |         |         |
| Stands for dynamic linklibrary        |         |         |
| will not have an entry point          |         |         |
| will have an entry point              |         |         |
| extension                             |         |         |
| self executable                       |         |         |
| isreusable component                  |         |         |
| collection of classes which hasmain() |         |         |

9.  What is the output?
<pre>
	class  bc 
    {
        internal virtual void display()
        {
            Console.WriteLine("bc display");
        }
    }
    class dc : bc 
    {
        internal override void display()
        {
            Console.WriteLine("dc display");
        }
    }
    class tc : bc 
    {
        internal new void display()
        {
            Console.WriteLine("tc display");
        }
    }
    
    class Program 
    {
        static void Main(string[] args)
        {
            bc b =new dc(); 
            b.display(); 
            b =new tc(); 
            b.display();
            Console.ReadLine();
        }
    }
</pre>

10. Explain the WSDL. Elements contained in the WSDL document. </br>

## SQL questions

1. Table Person

| PersonId | Code  | FirstName | Town                | Sex |
| -------- | ----- | --------- | ------------------- | --- |
| 100      | 12345 | JOHN      | Edinburgh           | m   |
| 101      | 12346 | ROBERT    | Manchester          | m   |
| 102      | 12347 | MICHAEL   | Birmingham          | m   |
| 103      | 12348 | DAVID     | Glasgow             | m   |
| 104      | 12349 | RICHARD   | Liverpool           | m   |
| 105      | 12350 | CHARLES   | Bristol             | m   |
| 106      | 12351 | JOSEPH    | Oxford              | m   |
| 107      | 12352 | MARY      | Cambridge           | f   |
| 108      | 12353 | PATRICIA  | Cardiff             | f   |
| 109      | 12354 | LINDA     | Brighton            | f   |
| 110      | 12355 | BARBARA   | Newcastle-upon-Tyne | f   |
| 111      | 12356 | ELIZABETH | Leeds               | f   |
| 112      | 12357 | JENNIFER  | York                | f   |

2. Table PData

| PersonId | Value |
| -------- | ----- |
| 100      | 12345 |
| 101      | 12346 |
| 102      | 12347 |
| 103      | 12348 |
| 104      | 12349 |
| 105      | 12350 |
| 106      | 12351 |
| 107      | 12352 |
| 108      | 12353 |
| 109      | 12354 |
| 110      | 12355 |
| 111      | 12356 |
|          |       |

1. how many rows in the table
2. how many men and female (using grouping)
3. change all persons named "JOHN" gender to "m"
4. set the "Town" field to "RIGA" for each even patient
5. display a list with the corresponding fields: "FirstName", "Value"
6. display a list with the corresponding fields: "FirstName", "Value" only for those where "value" exists
7. What indexes are needed for these tables?
8. what field type to choose for PersonId?
9. Is it possible to update the "Town" field for all records that have the value "Value" with one script? If "Yes", write a script.
10. How could these tables be optimized?