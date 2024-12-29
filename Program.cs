class Program{
    public static bool Consecutive(int [] a, int k){

        int contador = 1;
        for(int i=0;i<a.Length-1;i++){
            if(a[i]==a[i+1]){
                contador++;
            }
            else{
                if(contador==k){
                    return true;
                }
                contador=1; 
            }
        }  
        if(contador==k){
            return true;
        }
        return false;  
    }

    public static void Main(){
        int[] a = {1,1,1,1,1};
        int k=5;
        bool solution = Consecutive(a, k);
        Console.WriteLine(solution);
    }
}