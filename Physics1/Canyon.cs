namespace Physics1
{
	internal class Canyon
	{
		//Properties
		protected int bWeight;
		public int BWeight

		{
			get { return bWeight; }
			set { bWeight = value; }
		}

		protected int acc;
		public int Acc
		{
			get { return acc; }
			set { acc = value; }
		}
		//Constructors
		public Canyon(int bWeight, int acc)
		{
			BWeight =  bWeight;
			Acc = acc;
		}
		//Methods

		public int GetFinalValue()
		{
			return BWeight*Acc;
		}
    }
}
