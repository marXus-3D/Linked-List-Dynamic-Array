using D_A;

//DArray<int> arr = new DArray<int>(5);
//arr[0] = 1;
//arr[1] = 2;
//arr[2] = 3;
//arr[3] = 4;
//arr[4] = 5;
//arr[5] = 6;

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

LinkedArray<int> arr = new();
arr.Add(1);
arr.Add(2);
arr.Add(3);
arr.Add(4);
arr.Add(5);
arr.Add(6);
arr.Set(0,7);

for (int i = 0; i < arr.Count; i++)
    Console.WriteLine(arr[i]);