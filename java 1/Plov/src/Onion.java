
public class Onion {
	
	private int ready;
	
	public int Ready(){
			
			return ready;
		}

   boolean  cut_ready = false ;

   public void setCut_ready (boolean value){
	   cut_ready=value;
   }
   public boolean getCut_ready(){
   	return cut_ready;
   }
   
   private boolean dirty = true;
   public boolean GetDirty (){
   	return dirty;
   }
   public void SetDirty(boolean d){
   	dirty=d;
   }
   
   private boolean add = false;
   public boolean GetAdd (){
   	return add;
   }
   public void SetAdd(boolean a){
   	add=a;
   }

   public void Cook()
   {
       if (Ready() < 10)
       {
           ready++;
  
       }
   }
	
}
