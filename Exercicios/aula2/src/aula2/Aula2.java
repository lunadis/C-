package aula2;

public class Aula2 {
	
	private int opar;

	public int getOpar() {
		return opar;
	}

	public void setOpar(int opar) {
		this.opar = opar;
	}
	
	public void Oparcresc() {
		
		for(int opar=11; opar <= 250; ++opar) {
			++opar;
			System.out.println(opar);
		}
	}
	
		
	}

