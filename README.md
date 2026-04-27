# FactoryMethod_DesignPattern
What is the Factory Pattern?
The Factory Pattern is a creational design pattern that provides an interface for creating objects without exposing the instantiation logic to the client. Instead of calling constructors directly, you call a factory method that returns the appropriate object based on input parameters.
How This Code Works ?
1. The Product Interface (IPizza)
- Defines the contract that all pizza types must follow
- Ensures every pizza implements the Prepare() method

2. Concrete Products (pizzaCheese, pizzaPepperoni, pizzaSeafood)
- Different implementations of the IPizza interface
- Each provides its own Prepare() method with specific behavior

3. The Factory (pizzaFactory)
- Contains the createPizza() method that decides which pizza to create
- Encapsulates all instantiation logic in one place

4. The Client (Program.Main())
- Simply asks the factory for a pizza type
- Doesn't need to know how the pizza is created or which class handles it


Code Structure/
├── IPizza.cs           # Product interface
├── pizzaCheese.cs      # Concrete product
├── pizzaPepperoni.cs   # Concrete product  
├── pizzaSeafood.cs     # Concrete product
├── pizzaFactory.cs     # Factory class with creation logic
├── PizzaType.cs        # Enum for pizza types
└── Program.cs          # Client code demonstrating usage
