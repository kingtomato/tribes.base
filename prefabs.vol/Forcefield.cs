//--- export object begin ---//
instant SimGroup "ForceField" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 5.33333";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 -2.66666";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorForceField1" {
		dataBlock = "DoorForceField";
		name = "";
		position = "0 0 -2.66666";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		fadeTime = "0";
		closeTime = "1";
		Status = "close";
		center = "1";
	};
};
//--- export object end ---//
