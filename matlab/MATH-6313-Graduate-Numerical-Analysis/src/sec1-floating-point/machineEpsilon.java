public class machineEpsilon {
	
	public static void main(String[] args){
		float value = 1; // Start with 1 and then keep cutting in half until we get machine epsilon.
		int idx = 0; // Index variable.
		
		System.out.print("Single Precision\n");
		
		while ((1 + value) > 1) // Cut value until it gets too small to make a difference.
		{
			// Display the index and the result of 1 + value.
			System.out.print("Index: " + idx + "	" + "1 + value = " + (1 + value) + "\n");
			value = value / 2; // Cut value in half.
			idx++;
		}
		
		// The index for the cut where 1 + value is indistinguishable from 1 is the value 2^(idx - 1) machine epsilon.
		System.out.print("\nAt Index = " + idx + ", we get that 1 + value = 1, thus the machine epsilon for "
				+ "single precision is 2^(-" + (idx - 1) + ").\n\n");
		
		System.out.print("Double Precision\n");
		
		// Reseting everything for the double case.
		idx = 0;
		double value_double = 1; // The variable value_double is a double.
		while ((1 + value_double) > 1)
		{
			System.out.print("Index: " + idx + "	" + "1 + value_double = " + (1 + value_double) + "\n");
			value_double = value_double / 2;
			idx++;
		}
		
		System.out.print("\nAt Index = " + idx + ", we get that 1 + value_double = 1, thus the machine epsilon for "
				+ "double precision is 2^(-" + (idx - 1) + ").\n\n");	}

}
