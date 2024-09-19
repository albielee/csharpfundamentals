This is an example of how an abstract factory data structure works.

In this example, I create an abstract class 'Database' that creates virtual properties Connection and Command.
This abstract class is inherited by the SqlDatabase class (or any other class wanting to implement a database connection) and the virtaul properties are overridden.
