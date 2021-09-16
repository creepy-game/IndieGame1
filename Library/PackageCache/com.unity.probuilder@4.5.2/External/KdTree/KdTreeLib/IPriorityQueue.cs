<<<<<<< HEAD
﻿namespace UnityEngine.ProBuilder.KdTree
{
	interface IPriorityQueue<TItem, TPriority>
	{
		void Enqueue(TItem item, TPriority priority);

		TItem Dequeue();

		int Count { get; }
	}
}
=======
﻿namespace UnityEngine.ProBuilder.KdTree
{
	interface IPriorityQueue<TItem, TPriority>
	{
		void Enqueue(TItem item, TPriority priority);

		TItem Dequeue();

		int Count { get; }
	}
}
>>>>>>> 7cf0e2f442837203eb7c741f38b2f438425c3367
