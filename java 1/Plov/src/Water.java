
public class Water {
	
	private int ready;
	
public int Ready(){
		
		return ready;
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
