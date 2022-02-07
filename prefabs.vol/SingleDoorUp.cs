//--- export object begin ---//
instant SimGroup "SingleDoorUp" {
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
	instant Moveable "DoorFive1" {
		dataBlock = "DoorFive";
		name = "";
		position = "0 0 -2.66666";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		closeTime = "1";
		Status = "close";
		center = "1";
		fadeTime = "0";
	};
};
//--- export object end ---//
