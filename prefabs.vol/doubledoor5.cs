//--- export object begin ---//
instant SimGroup "DoubleDoor5" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "4.5 0 0";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 0";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "-4.5 0 0";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorFourLeft1" {
		dataBlock = "DoorFourLeft";
		name = "";
		position = "0 0 0";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		closeTime = "1";
		Status = "close";
		center = "1";
		fadeTime = "0";
	};
	instant Moveable "DoorFourRight1" {
		dataBlock = "DoorFourRight";
		name = "";
		position = "0 0 0";
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
