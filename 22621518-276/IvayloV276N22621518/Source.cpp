#include<iostream>
#include<iomanip>
#include<string>
#include<fstream>
#include<cstdlib>
using namespace std;
struct ComputerConfiguration
{
	char serialnumber[8];
	string brand;
	string model;
	string processormaker;
	int corescount;
	int RAM;
	double price;
	string status;
};
void AddNew(struct ComputerConfiguration Store[],int &size,const unsigned int maxsize)//1
{
	int n, status;
	do { cout << "Count of NEW Configurations:"; cin >> n; } while (n<1 || n>(maxsize - size));
	int backup = size;
	size = size + n;
	for(int i=0; i<n; i++)
	{
		cout << "Enter Serial Number !(8 digits ONLY)!:"; cin >> Store[backup+i].serialnumber;
		cout << "Enter Brand:"; getline(cin.ignore(1000,'\n'), Store[backup+i].brand);
		cout << "Enter Model:"; getline(cin, Store[backup + i].model);
		cout << "Enter Maker of the Processor:"; getline(cin, Store[backup+i].processormaker);
		cout << "Enter Count of Cores:"; cin>>Store[backup+i].corescount;
		cout << "Enter RAM:"; cin >> Store[backup+i].RAM;
		cout << "Enter Price:"; cin >> Store[backup + i].price;
		cout << "Select Status:"<<endl;
		cout << "1) purchased" << endl;
		cout << "2) unpurchased!" << endl;
		do { cout << "Select 1 or 2 to continue:"; cin >> status; } while (status != 1 && status != 2);
		switch (status)
		{
		case 1: Store[backup + i].status = "purchased"; break;
		case 2: Store[backup + i].status = "unpurchased"; break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	}
	cout << endl;
}
void ShowData(struct ComputerConfiguration Store[],const unsigned int size)//2
{
	for (int i = 0; i < size; i++)
	{
		cout << "Serial Number: " << Store[i].serialnumber << "\nBrand: " << Store[i].brand
			<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
			<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
			<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
	}
	cout << endl;
}
void MaxRAM(struct ComputerConfiguration Store[], const unsigned int size)//3a
{
	int max = Store[0].RAM;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].RAM>max) max = Store[i].RAM;
	}
	cout << endl << "MAX RAM = " << max << " GB" << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].RAM == max)
		{
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
}
void ProcessorMakerSearch(struct ComputerConfiguration Store[], const unsigned int size,string maker)//3b
{
	int br = 0;
	cout << endl << "Processor Maker: " << maker << endl<<endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].processormaker == maker)
		{
			br++;
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
	if (br == 0) cout << "We dont have processor made by " + maker<<endl<<endl;
}
void SUBMENU3(struct ComputerConfiguration Store[], const unsigned int size)//3
{
	char submenu3;
	string maker;
	do
	{
		cout << endl;
		cout << "Submenu 3 with functions:" << endl;
		cout << "3.A) Max RAM configurations" << endl;
		cout << "3.B) Search by maker of the processor" << endl;
		cout << "3.C) Exit from Submenu 3" << endl;
		do
		{
			cout << endl << "Choose A, B or C: "; cin >> submenu3;
		} while (submenu3 != 'A' && submenu3 != 'B' && submenu3 != 'C');

		switch (submenu3)
		{
		case 'A': MaxRAM(Store,size); break;
		case 'B': cout << "Search by Processor Maker:"; 
			getline(cin.ignore(1000,'\n'), maker); ProcessorMakerSearch(Store,size,maker); break;
		case 'C': break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	} while (submenu3 != 'C');
}
void SortByPrice(struct ComputerConfiguration Store[], const unsigned int size)//4
{
	ComputerConfiguration buf;
	for (int k = size; k > 1; k--)
	{
		for (int i = 0; i < k - 1; i++)
		{
			//if (Store[i].price < Store[i + 1].price) //NIZHODQSHT RED
			if (Store[i].price > Store[i + 1].price) //VUZHODQSHT RED
			{
				buf = Store[i];
				Store[i] = Store[i + 1];
				Store[i + 1]= buf;
			}
		}
	}
}
void OutputDataBinary(struct ComputerConfiguration Store[], const unsigned int size)//5
{
	fstream ODFB;
	ODFB.open("UpdatedDATA-Binary.dat", ios::binary | ios::out);
	if (ODFB.fail()) cout << "Unsuccessful connection with the file!Try again" << endl;
	else cout << "Sucessful Connection!" << endl;
	for (int i = 0; i < size; i++)
	{
		ODFB.write(Store[i].serialnumber, 8);
		ODFB.write((char*)&Store[i].brand, sizeof(Store[i].brand));
		ODFB.write((char*)&Store[i].model, sizeof(Store[i].model));
		ODFB.write((char*)&Store[i].processormaker, sizeof(Store[i].processormaker));
		ODFB.write((char*)&Store[i].corescount, sizeof(Store[i].corescount));
		ODFB.write((char*)&Store[i].RAM, sizeof(Store[i].RAM));
		ODFB.write((char*)&Store[i].price, sizeof(Store[i].price));
		ODFB.write((char*)&Store[i].status, sizeof(Store[i].status));
	}
	ODFB.close();
}
void InputDataBinary(struct ComputerConfiguration Store[], const unsigned int size)//5
{
	fstream IDFB;
	IDFB.open("UpdatedDATA-Binary.dat", ios::binary | ios::in);
	if (IDFB.fail()) cout << "Unsuccessful connection with the file!Try again" << endl;
	else cout << "Sucessful Connection!" << endl;
	for (int i = 0; i < size; i++)
	{
		IDFB.read(Store[i].serialnumber, 8);
		IDFB.read((char*)&Store[i].brand, sizeof(Store[i].brand));
		IDFB.read((char*)&Store[i].model, sizeof(Store[i].model));
		IDFB.read((char*)&Store[i].processormaker, sizeof(Store[i].processormaker));
		IDFB.read((char*)&Store[i].corescount, sizeof(Store[i].corescount));
		IDFB.read((char*)&Store[i].RAM, sizeof(Store[i].RAM));
		IDFB.read((char*)&Store[i].price, sizeof(Store[i].price));
		IDFB.read((char*)&Store[i].status, sizeof(Store[i].status));
	}
	IDFB.close();
}
void UnsoldSortedBySerialNumberConfiguration(struct ComputerConfiguration Store[], const unsigned int size)//6a
{
	cout << endl;
	cout << "Unpurchased computers sorted by serial number" << endl;
	ComputerConfiguration buf;
	for (int k = size; k > 1; k--)
	{
		for (int i = 0; i < k - 1; i++)
		{
			//if (strcmp(Store[i].serialnumber,Store[i+1].serialnumber)<0) //NIZHODQSHT RED
			if (strcmp(Store[i].serialnumber,Store[i+1].serialnumber)>0)//VUZHODQSHT RED
			{
				buf = Store[i];
				Store[i] = Store[i + 1];
				Store[i + 1] = buf;
			}
		}
	}
	for (int i = 0; i < size; i++)
	{
		if (Store[i].status == "unpurchased")
		{
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
}
void SearchByBrandAndModel(struct ComputerConfiguration Store[], const unsigned int size,string brand,string model)//6b
{
	int br = 0;
	cout << "Brand: " << brand;
	cout << endl << "Model: " << model << endl << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].brand == brand&&Store[i].model==model)
		{
			br++;
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
	if (br == 0) cout << "We dont have computer with brand " + brand + " and model " + model << endl;
}
void SUBMENU6(struct ComputerConfiguration Store[], const unsigned int size)//6
{
	char submenu6;
	string brand,model;
	do
	{
		cout << endl;
		cout << "Submenu 6 with functions:" << endl;
		cout << "6.A) Sort by serial number and show unpurchased configurations" << endl;
		cout << "6.B) Search by Brand and Model" << endl;
		cout << "6.C) Exit from Submenu 6" << endl;
		do
		{
			cout << endl << "Choose A, B or C: "; cin >> submenu6;
		} while (submenu6 != 'A' && submenu6 != 'B' && submenu6 != 'C');

		switch (submenu6)
		{
		case 'A': UnsoldSortedBySerialNumberConfiguration(Store,size); break;
		case 'B': cout << "Enter Brand:";
			getline(cin.ignore(1000, '\n'), brand); 
			cout << "Enter Model:";
			getline(cin, model);
			SearchByBrandAndModel(Store,size,brand,model); break;
		case 'C': break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	} while (submenu6 != 'C');
}
void SearchByBrandAndModel2(struct ComputerConfiguration Store[], const unsigned int size,string brand, string model)//7a
{
	int br = 0;
	cout << "Brand: " << brand;
	cout << endl << "Model: " << model << endl << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].brand == brand && Store[i].model == model&& Store[i].status == "unpurchased")
		{
			br++;
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
	if (br == 0) cout << "We dont have computer with brand " + brand + " and model " + model + " or it is purchased!" << endl;
}
void ProcessorMakerSearch2(struct ComputerConfiguration Store[], const unsigned int size,string maker)//7a
{
	int br = 0;
	cout << endl << "Processor Maker: " << maker << endl << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].processormaker == maker && Store[i].status == "unpurchased")
		{
			br++;
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
	if (br == 0) cout << "We dont have processor made by " + maker + " or it is purchased!" << endl << endl;
}
void SearchByCoresCount(struct ComputerConfiguration Store[], const unsigned int size,int cores)//7a
{
	int br = 0;
	cout << endl << "Cores: " << cores << endl << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].corescount == cores && Store[i].status == "unpurchased")
		{
			br++;
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
	if (br == 0) cout << "We dont have computer configuration with " <<cores<<" cores or it is purchased!" << endl << endl;
}
void SearchByRAM(struct ComputerConfiguration Store[], const unsigned int size,int RAM)//7a
{
	int br = 0;
	cout << endl << "RAM: " << RAM << endl << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].RAM == RAM && Store[i].status == "unpurchased")
		{
			br++;
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl << endl;
		}
	}
	if (br == 0) cout << "We dont have computer configuration with " << RAM << "GB (RAM) or it is purchased!" << endl << endl;
}
void MaxPrice(struct ComputerConfiguration Store[], const unsigned int size)//7a
{
	double max=0;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].status == "unpurchased") max = Store[i].price; break;
	}
	for (int i = 0; i < size; i++)
	{
		if (Store[i].price > max && Store[i].status=="unpurchased") max = Store[i].price;
	}
	cout << endl << "MAX Price = " << max << " LV" << endl;
	for (int i = 0; i < size; i++)
	{
		if (Store[i].price == max && Store[i].status == "unpurchased")
		{
			cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
				<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
				<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
				<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl;
		}
	}
}
void SearchingForTheRightConfigurationMenu(struct ComputerConfiguration Store[], const unsigned int size)//7a-menu
{
	int submenu7;
	string brand, model,maker;
	int cores, RAM;
	do
	{
		cout << endl;
		cout << "Subsubmenu 7.1 with functions --> !(Unpurchased Computer Configurations ONLY)! Search By:" << endl;
		cout << "7.1.(1) Brand and Model " << endl;
		cout << "7.1.(2) Maker of the processor" << endl;
		cout << "7.1.(3) Count of the cores " << endl;
		cout << "7.1.(4) RAM" << endl;
		cout << "7.1.(5) MAX Price" << endl;
		cout << "7.1.(6) Exit from Submenu 7.1" << endl;
		do
		{
			cout << endl << "Choose a number from 1 to 6: "; cin >> submenu7;
		} while (submenu7 < 1 || submenu7>6);

		switch (submenu7)
		{
		case 1: cout << "Enter Brand:";
			getline(cin.ignore(1000, '\n'), brand);
			cout << "Enter Model:";
			getline(cin, model);
			SearchByBrandAndModel2(Store,size,brand, model); break;

		case 2: cout << "Search by Processor Maker:";
			getline(cin.ignore(1000, '\n'), maker); ProcessorMakerSearch2(Store,size,maker); break;

		case 3: cout << "Enter cores count: "; cin >> cores;
			SearchByCoresCount(Store,size,cores); break;

		case 4:  cout << "Enter RAM: "; cin >> RAM;
			SearchByRAM(Store,size,RAM); break;

		case 5: MaxPrice(Store,size); break;
		case 6: break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	} while (submenu7 != 6);
}
void Selling(struct ComputerConfiguration Store[], const unsigned int size)//7b
{
	bool flag = false;
	string wantednumber;
	int buy,discount,discountcode;
	cout << "Enter Serial Number !(8 digits ONLY)!:"; getline(cin.ignore(1000,'\n'),wantednumber);
	for (int i = 0; i < size; i++)
	{
		if (Store[i].serialnumber==wantednumber)//!(strcmp(Store[i].serialnumber, wantednumber))
		{
			flag = true;
			if (Store[i].status == "unpurchased")
			{
				cout << "Serial Number: " << Store[i].serialnumber << "\nBrand:" << Store[i].brand
					<< "\nModel: " << Store[i].model << "\nProcessor(made by): " << Store[i].processormaker
					<< "\nCores: " << Store[i].corescount << "\nRAM: " << Store[i].RAM << " GB \nPrice: "
					<< Store[i].price << "LV. \nStatus: " << Store[i].status << endl;
				cout << "Do you want to buy it?" << endl;
				cout << "1) YES!" << endl;
				cout << "2) NO!" << endl;
				do { cout << "Select 1 or 2 to continue:"; cin >> buy; } while (buy != 1 && buy != 2);
				switch (buy)
				{
				case 1:
				{
					cout << endl;
					cout << "Do you have a discount code?" << endl;
					cout << "1) YES!" << endl;
					cout << "2) NO!" << endl;
					do { cout << "Select 1 or 2 to continue:"; cin >> discount; } while (discount != 1 && discount != 2);
					switch (discount)
					{
					case 1:
					{
						cout << "Enter discount code:"; cin >> discountcode;
						if (sizeof(discountcode) == 4 && discountcode % 8 == 0 && discountcode % 7 == 0)
						{
							cout << "Old Price: " << Store[i].price << " LV." << endl;
							cout << "New Price: " << Store[i].price - (Store[i].price * 0.05) << " LV." << endl;
							cout << ":)   !SUCCESSFUL PURCHASE!   :)" << endl;
							Store[i].status = "purchased";
						}
						else
						{
							cout << "Price: " << Store[i].price << " LV." << endl;
							cout << ":)   !SUCCESSFUL PURCHASE!   :)" << endl;
							Store[i].status = "purchased";
						}
						break;
					}
					case 2:
					{
						cout << "Price: " << Store[i].price << " LV." << endl;
						cout << ":)   !SUCCESSFUL PURCHASE!   :)" << endl;
						Store[i].status = "purchased"; break;
					}
					default: cout << "ERROR!"; system("PAUSE"); exit(1);
					}
					break;
				}
				case 2: cout << "Thank you!Come again!" << endl; break;
				default: cout << "ERROR!"; system("PAUSE"); exit(1);
				}
			}
			else cout << " The Computer Configuration has been sold!" << endl << endl;
		}
		
	}
	if (flag == false)
	{
		cout << "It isn't found a Computer Configuration with the specified Serial Number!"
			<< endl << endl;
	}
}
void SUBMENU7(struct ComputerConfiguration Store[], const unsigned int size)//7
{
	char submenu7;
	do
	{
		cout << endl;
		cout << "Submenu 7 with functions:" << endl;
		cout << "7.A) Searching For The Right Configuration(Menu)" << endl;
		cout << "7.B) Buying a Computer Configuration?" << endl;
		cout << "7.C) Exit from Submenu 7" << endl;
		do
		{
			cout << endl << "Choose A, B or C: "; cin >> submenu7;
		} while (submenu7 != 'A' && submenu7 != 'B' && submenu7 != 'C');

		switch (submenu7)
		{
		case 'A': SearchingForTheRightConfigurationMenu(Store,size); break;
		case 'B': Selling(Store,size); break;
		case 'C': break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	} while (submenu7 != 'C');
}
void InputData(struct ComputerConfiguration Store[], const unsigned int size)
{
	fstream IDF;
	IDF.open("DATA.txt", ios::in);
	if (IDF.fail()) cout << "Unsuccessful connection with the file!Try again" << endl;
	else cout << "The data is ready for work!" << endl;
	for (int i = 0; i < size; i++)
	{
		IDF >> Store[i].serialnumber >> Store[i].brand >> Store[i].model >> Store[i].processormaker
			>> Store[i].corescount >> Store[i].RAM >> Store[i].price >> Store[i].status;
	}
	IDF.close();
}
void OutputData(struct ComputerConfiguration Store[], const unsigned int size)
{
	fstream ODF;
	ODF.open("UpdatedDATA.txt", ios::out);
	if (ODF.fail()) cout << "Unsuccessful connection with the file!Try again" << endl;
	else cout << "Sucessful Connection!" << endl;
	for (int i = 0; i < size; i++)
	{
		ODF << Store[i].serialnumber <<' '<< Store[i].brand << ' ' << Store[i].model << ' ' << Store[i].processormaker
			<< ' ' << Store[i].corescount << ' ' << Store[i].RAM << ' ' << Store[i].price << ' ' << Store[i].status<<endl;
	}
	ODF.close();
}
void InputUpdatedData(struct ComputerConfiguration Store[], const unsigned int size)
{
	fstream IDF;
	IDF.open("UpdatedDATA.txt", ios::in);
	if (IDF.fail()) cout << "Unsuccessful connection with the file!Try again" << endl;
	else cout << "The data is ready for work!" << endl;
	for (int i = 0; i < size; i++)
	{
		IDF >> Store[i].serialnumber >> Store[i].brand >> Store[i].model >> Store[i].processormaker
			>> Store[i].corescount >> Store[i].RAM >> Store[i].price >> Store[i].status;
	}
	IDF.close();
}
void SUBMENU8(struct ComputerConfiguration Store[], int &size)//8
{
	int submenu8;
	do
	{
		cout << endl;
		cout << "Submenu 8 with functions:" << endl;
		cout << "1. InputData - starting data for the program (from a file)" << endl;
		cout << "2. OutputData - recording the new and updated data on a file" << endl;
		cout << "3. InputUpdatedData - reading and taking the new and updated data from the file from point (2)" << endl;
		cout << "4. Exit from Submenu 8" << endl;
		do
		{
			cout << endl << "Choose 1,2,3 or 4: "; cin >> submenu8;
		} while (submenu8 < 1 || submenu8>4);
		switch (submenu8)
		{
		case 1: 
		{
			InputData(Store, size);
			do
			{
				cout << "Enter the count of the Computer Configurations:";
				cin >> size;
			} while (size < 2 || size>100); break; 
		}
		case 2: OutputData(Store, size); break;
		case 3: 
		{
			do
			{
				cout << "Enter the count of the Computer Configurations:";
				cin >> size;
			} while (size < 2 || size>100);
			InputUpdatedData(Store, size);
			 break;
		}
		case 4: break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	} while (submenu8 != 4);
}

void main()
{
	const int MaxComputers = 100;
	int menu,ArrayLength;
	do 
	{ 
		cout << "Enter the count of the Computer Configurations:"; 
		cin >> ArrayLength;
	} while (ArrayLength < 2 || ArrayLength>100);
	ComputerConfiguration Store[MaxComputers];
	cout << endl;
	InputData(Store,ArrayLength);
	do
	{
		cout << endl;
		cout << "Menu with main functions:" << endl;
		cout << "1)Add configuration" << endl;
		cout << "2)Show all data" << endl;
		cout << "3)Searching for data and showing it" << endl;
		cout << "4)Sorting the configurations by Price" << endl;
		cout << "5)File management" << endl;
		cout << "6)Submenu" << endl;
		cout << "7)Configuration selling" << endl;
		cout << "8)Automatically fill the data from file and record it on file" << endl;
		cout << "9)Exit from the program" << endl;
		cout <<endl<< "Enter a number from 1 to 9: ";
		do 
		{
		cin >> menu;
		} while (menu < 1 || menu>9);
		cout << endl;
		switch (menu)
		{
		case 1: AddNew(Store, ArrayLength, MaxComputers); break;
		case 2: ShowData(Store,ArrayLength); break;
		case 3: cout << "WELCOME!" << endl; SUBMENU3(Store, ArrayLength); break;
		case 4: SortByPrice(Store, ArrayLength); break;
		case 5: OutputDataBinary(Store, ArrayLength); InputDataBinary(Store, ArrayLength); break;
		case 6: cout << "WELCOME!" << endl; SUBMENU6(Store, ArrayLength); break;
		case 7: cout << "WELCOME!" << endl; SUBMENU7(Store, ArrayLength); break;
		case 8: cout << "WELCOME!" << endl; SUBMENU8(Store, ArrayLength); break;
		case 9: exit(1); break;
		default: cout << "ERROR!"; system("PAUSE"); exit(1);
		}
	} while (menu != 9);
}
