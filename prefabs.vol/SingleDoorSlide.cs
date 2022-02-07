//--- export object begin ---//
instant SimGroup "SingleDoorSide" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "-6.66666 0 0";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "3.33333 0 0";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorFive1" {
		dataBlock = "DoorFive";
		name = "";
		position = "3.33333 0 0";
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
