int[] array = { 1, 2, 4, 5, 6, 4, 8};

int lenghtArray = array.Length;
int find = 4;

int index = 0;

while(index < lenghtArray){
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}