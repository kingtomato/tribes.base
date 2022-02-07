//--- export object begin ---//
instant SimGroup "ForceField4x8" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 2.66666";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 -1.33333";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorForceField1" {
		dataBlock = "DoorForceField4x8";
		name = "";
		position = "0 0 -1.33333";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		center = "1";
		Status = "close";
		closeTime = "1";
		fadeTime = "0";
	};
};
//--- export object end ---//
