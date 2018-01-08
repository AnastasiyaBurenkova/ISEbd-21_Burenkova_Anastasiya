
public class WaterTap {

	 private boolean open=false;
	 
	    public boolean GetOpen(){
	    	return open;
	    	
	    }
	    
	    public void SetOpen(boolean o){
	    	open=o;
	    }
	    
	    public void Wash_rice(Kabach rice)
	     {
	         if (open)
	         {
	             rice.SetDirty(false);
	         }
	     }
	    
	    public void Wash_carrot(Carrot carrot)
	     {
	         if (open)
	         {
	        	 carrot.SetDirty(false);
	         }
	     }
	    
	    public void Wash_onoin(Onion onion)
	     {
	         if (open)
	         {
	        	 onion.SetDirty(false);
	         }
	     }
	    
	    public void Wash_meat(Potato meat)
	     {
	         if (open)
	         {
	        	 meat.SetDirty(false);
	         }
	     }
	    
}
