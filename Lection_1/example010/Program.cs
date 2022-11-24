int[] array = {13,62,322,4,513,62,71,8};

int n = array.Length;
int find = 8;
int index = 0;

while(index < n ){
    if(array[index] == find){
    Console.WriteLine(index);
    break;
    index++;
    }
}