using System;

public class Class1
{
	private double account;
	private int pin;
	private string name;

	public double Account //PROPERTY
	{
		get
		{
			return account;
		}
		set
		{
			account = value;
		}
	}
	public int Pin //PROPERTY
	{
		get
		{
			return pin;
		}
		set
		{
			pin = value;
		}
	}
	public string Name //PROPERTY
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}


	public Class1(string name, double account, int pin )
	{
		this.name = name;
		this.account = account;
		this.pin = pin;

	}
}
