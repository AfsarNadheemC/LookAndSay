namespace LookAndSay
{
    class Program
    {
        public static void Main(string[] args)
        {
            List <int> list1 = new List<int>();
            List <int> list2 = new List<int>();

            list1.Add (1);


            int rows = 10; // Change the value to change number of rows !

            for (int i = 0; i < rows; i++){
                
                foreach (int l1 in list1){
                    Console.Write(l1);
                }
                

                for (int j=0;j<list1.Count;j++){
                    int temp = list1[j];
                    int tcount = 0;
                    while (j<list1.Count && temp == list1[j] ){
                        tcount++;
                        j++;
                    }
                    list2.Add (tcount);
                    list2.Add (temp);
                    j--;
                }
                
                Console.WriteLine ("");

                list1.Clear ();
                
                foreach (int l2 in list2) {
                    list1.Add (l2);
                }

                list2.Clear ();
            }
        }
    }
}