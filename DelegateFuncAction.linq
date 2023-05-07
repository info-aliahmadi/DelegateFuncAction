<Query Kind="Program" />

void Main()
{

	RelaxingOnTheBeach(DrinkWater);
	RelaxingOnTheBeach(DrinkBeer);
	RelaxingOnTheBeach(DrinkLemonade);

	Run(DrinkWater);


	// Delegate
	var drinkAction = new DrinkingAction(DrinkBeer);
	drinkAction.Invoke();

	// Func
	/*  Func Return the result  */
	Func<int, int, int> Add = (int a, int b) => a + b;
	var result = Add(2, 2);
	result.Dump();
	
	Func<int, int, int> Sub = Subtract;
	Sub(2,2).Dump();
	
	// with anonymous method
	Func<int> getRandomNumber = delegate()
								{
									Random rnd = new Random();
									return rnd.Next(1, 100);
								};
								
	getRandomNumber.Invoke().Dump();							
	

	// Action
	/*  Action doesn't return anything  */
	Action<int, int> PrintNumber = (n, n1) => n.Dump();

	PrintNumber(5, 8);

}

public int Subtract(int a, int b)
{
	return a - b;
}

public void DrinkWater()
{
	"Drinking Water".Dump();
}
public void DrinkBeer()
{
	"Drinking Beer".Dump();
}
public void DrinkLemonade()
{
	"Drinking Lemonade".Dump();
}

public delegate void DrinkingAction();

public void RelaxingOnTheBeach(DrinkingAction drink)
{
	"Relaxing on the Beach".Dump();
	if (drink != null)
	{
		drink();
	}
}
public void Run(DrinkingAction drink)
{
	"Running 10 miles".Dump();
	if (drink != null)
	{
		drink();
	}
}
// You can define other methods, fields, classes and namespaces here