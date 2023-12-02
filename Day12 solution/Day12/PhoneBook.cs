using System;
namespace Day12
{
	public class PhoneBook
	{
		int cnt;
		string[] Name;
        long[] PhoneNumber;
		int size;

		public PhoneBook( int size)
		{
			this.size = size;
			this.Name = new string[size];
			this.PhoneNumber = new long[size];
		}
		public int GetSize(int order)
		{
			return order;
		}
		//Adding new number to the array
		public void AddPhone(string Name,long PhoneNumber)
		{
			
				this.Name[cnt] =Name ;
				this.PhoneNumber[cnt]= PhoneNumber;
				cnt += 1;
        }
		//display all numbers and name
		public void GetAll()
		{
			for (int i = 0; i <size; i++)
			{
				if (Name[i]!=null)
					Console.WriteLine($"{i+1}- {this.Name[i]} : {this.PhoneNumber[i]}");
			}
		}

		//Display number base on name 
		public long GetNumber(string name)
		{
			for (int i = 0; i < size; i++)
			{
				if (Name[i] == name)
				{
					return PhoneNumber[i];
					//Console.WriteLine($"{this.PhoneNumber[i]}");
                }
				
			}
            return 0;
        }
		//Edit the number
		public void EditNumber(string name , long number)
		{
			for (int i = 0; i < size; i++)
			{
				if (Name[i] == name)
				{
					PhoneNumber[i] = number;
					Console.WriteLine($"Salma updated number : {this.PhoneNumber[i]}");
				}
			}

		}
		//Indexer property
		// this keyword refare to the object 
        public long this[string name]
        {
			// the get is used to display the record
			get
			{
                for (int i = 0; i < size; i++)
                {
                    if (Name[i] == name)
                    {
                        return PhoneNumber[i];
                    }

                }
                return 0;
            }

			//set can be used to add or update record 
			set
			{
				if (Name[cnt]!= name)
				{
                    //This to add new record

                    Name[cnt] = name;
                    PhoneNumber[cnt] = value;
                    cnt += 1;
				}
				else
				{
					//This to update record 
					for (int i = 0; i < size; i++)
					{
						if (Name[i] == name)
						{
							PhoneNumber[i] = value;
						}
					}
				}
            }
		}

    }
}

