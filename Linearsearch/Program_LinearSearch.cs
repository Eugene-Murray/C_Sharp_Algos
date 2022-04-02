Console.WriteLine("Algos Linear Search");

static Boolean LinearSearch(int[] input, int n) {
    foreach(int current in input) {
        if (n == current) {
            return true;
        }
    }

    return false;
}

int[] arr = {1, 2, 3, 4, 5, 6};

// Via Custom Method
Console.WriteLine(LinearSearch(arr, 5));

// Via build-in methods
int item = Array.Find(arr, element => element == 3);
Console.WriteLine(item);

int[] items = Array.FindAll(arr, element => element >= 5);
Array.ForEach(items, Console.WriteLine);







