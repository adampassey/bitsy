﻿using UnityEngine;
using UnityEditor;
using System.Collections;

using AdamPassey.Inventory;

namespace AdamPassey.Editor.MenuItems {

	public class InventoryItemMenu : MonoBehaviour {

		[MenuItem ("GameObject/Bitsy/Items/Inventory Item")]
		public static void CreateInventoryItemMenuItem() {
			GameObject obj = new GameObject();
			obj.name = "Inventory Item";
			obj.AddComponent<SpriteRenderer>();
			obj.AddComponent<BoxCollider2D>();
			obj.AddComponent<Rigidbody2D>();
			obj.AddComponent<InventoryItem>();
		}
	}
}
