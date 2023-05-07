<Query Kind="Program" />

void Main()
{
	//DrinkWater();
	//DrinkBeer();
	//DrinkLemonade();

	RelaxingOnTheBeach(DrinkWater);
	RelaxingOnTheBeach(DrinkBeer);
	RelaxingOnTheBeach(DrinkLemonade);

	Run(DrinkWater);

	var drinkAction = new DrinkingAction(DrinkBeer);
	drinkAction.Invoke();

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
