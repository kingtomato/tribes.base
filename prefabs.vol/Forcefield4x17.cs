//--- export object begin ---//
instant SimGroup "ForceField4x17" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 6.66665";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 -3.33332";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorForceField1" {
		dataBlock = "DoorForceField4x17";
		name = "";
		position = "0 0 -3.33332";
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
