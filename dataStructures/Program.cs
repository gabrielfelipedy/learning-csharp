// See https://aka.ms/new-console-template for more information

int[] array = new int[4];

for(int i = 0; i < array.Length; i++) {
  array[i] = i+1;
}

for(int i = 0; i < array.Length; i++)
  Console.WriteLine(array[i]);

int[] array2 = new int[] {12, 13, 54, 12};

for(int i = 0; i < array2.Length; i++)
  Console.WriteLine(array2[i]);

int[] array3 = {-1, -2, 3};

for(int i = 0; i < array3.Length; i++)
  Console.WriteLine(array3[i]);
