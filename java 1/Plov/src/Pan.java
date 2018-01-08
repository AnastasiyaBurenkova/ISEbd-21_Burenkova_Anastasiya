import javax.swing.JOptionPane;

public class Pan {
	private Onion[] onion;
	private Potato[] potato;
	private Carrot[] carrot;
	private Kabach[] kabach;
	private Water[] water;
	private Salt salt;
	private Oil oil;

	public boolean IsReady1 = false;

	public void Init_Onion(int count_Onion) {

		onion = new Onion[count_Onion];
	}

	public void Init_Potato(int count_Potato) {
		potato = new Potato[count_Potato];

	}

	public void Init_Carrot(int count_Carrot) {
		carrot = new Carrot[count_Carrot];

	}

	public void Init_Kabach(int count_Kabach) {
		kabach = new Kabach[count_Kabach];

	}

	public void Init_Water(int count_Water) {
		water = new Water[count_Water];

	}

	public void AddOnion(Onion o) {
		for (int i = 0; i < onion.length; i++) {
			if (onion[i] == null) {
				onion[i] = o;
				return;
			}
		}
	}

	public void Addpotato(Potato m) {
		for (int i = 0; i < potato.length; i++) {
			if (potato[i] == null) {
				potato[i] = m;
				return;
			}
		}
	}

	public void Addkabach(Kabach r) {
		for (int i = 0; i < kabach.length; i++) {
			if (kabach[i] == null) {
				kabach[i] = r;
				return;
			}
		}
	}

	public void AddCarrot(Carrot c) {
		for (int i = 0; i < carrot.length; i++) {
			if (carrot[i] == null) {
				carrot[i] = c;
				return;
			}
		}
	}

	public void AddWater(Water w) {
		for (int i = 0; i < water.length; i++) {
			if (water[i] == null) {
				water[i] = w;
				return;
			}
		}
	}

	public void AddSalt(Salt s) {
		salt = s;
		salt.SetCount(true);
	}

	public void AddOil(Oil o) {
		oil = o;
		oil.SetCount(true);
	}

	public boolean Check() {
		if (onion == null) {
			return false;
		}
		if (carrot == null) {
			return false;
		}
		if (potato == null) {
			return false;
		}
		for (int o = 0; o < onion.length; ++o) {
			if (onion[o] == null)
				return false;
		}

		for (int m = 0; m < potato.length; ++m) {
			if (potato[m] == null)
				return false;
		}
		for (int c = 0; c < carrot.length; ++c) {
			if (carrot[c] == null)
				return false;
		}

		if (salt == null) {
			return false;

		}
		if (oil == null) {
			return false;

		}
		if (kabach == null) {
			return false;
		}
		for (int r = 0; r < kabach.length; ++r) {
			if (kabach[r] == null)
				return false;
		}
		return true;
	}

	public boolean Check2() {

		if (water == null) {
			return false;
		}

		for (int w = 0; w < water.length; ++w) {
			if (water[w] == null)
				return false;
		}
		return true;
	}

	public void Cook() {
		if (Check()) {
			for (int i = 0; i < carrot.length; i++) {
				carrot[i].Cook();
			}
			for (int i = 0; i < onion.length; i++) {
				onion[i].Cook();
			}
			for (int i = 0; i < potato.length; i++) {
				potato[i].Cook();
			}
			for (int i = 0; i < kabach.length; i++) {
				kabach[i].Cook();
			}
		}
		if (Check2()) {
			for (int i = 0; i < water.length; i++) {
				water[i].Cook();
			}
			
		}

	}

}
