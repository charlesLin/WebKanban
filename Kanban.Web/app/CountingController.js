(function () {
	'use strict';
	angular
			.module('kanbanApp')
			.controller('CountingController', CountingController);

	CountingController.$inject = ['$location', '$scope', '$timeout'];

	function CountingController($location, $scope, $timeout) {
		/* jshint validthis:true */
		var vm = this;
		vm.title = 'CountingController';
		vm.finished = 0;
		vm.total = 2000;
		vm.increase = increase;
		vm.lines = new Array(12);
		for (var i = 0; i < vm.lines.length; i++) {
			vm.lines[i] = 0;
		}
		vm.segments = {};

		var counting = $.connection.countingHub;
		counting.client.increase = function (lineId) {
			vm.finished ++;
			vm.lines[lineId - 1]++;
			addSegment();
			
			$scope.$apply();
		}
		$.connection.hub.start();


		function increase(lineId) {
			counting.server.increase(lineId);
		}

		function addSegment() {
			var hour = new Date().getHours();
			var key = ('0' + hour).slice(-2);

			if (vm.segments[key]) vm.segments[key]++;
			else vm.segments[key] = 1;
		}

		activate();

		function activate() {
			resetLinesOnHour();
			resetSegmentsOnDay();
		}

		function resetLinesOnHour() {
			var d = new Date(),
			h = new Date(d.getFullYear(), d.getMonth(), d.getDate(), d.getHours() + 1, 0, 0, 0),
			//h = new Date(d.getFullYear(), d.getMonth(), d.getDate(), d.getHours(), d.getMinutes() + 1, 0, 0),

			e = h - d;
			$timeout(resetLinesOnHour, e);
			resetLines();
		}



		function resetLines() {
			for (var j = 0; j < vm.lines.length; j++) {
				vm.lines[j] = 0;
			}
		}

		function resetSegmentsOnDay() {
			var d = new Date(),
			//h = new Date(d.getFullYear(), d.getMonth(), d.getDate(), d.getHours() + 1, 0, 0, 0),
			h = new Date(d.getFullYear(), d.getMonth(), d.getDate() + 1, d.getHours(), d.getMinutes(), 0, 0),

			e = h - d;
			$timeout(resetSegmentsOnDay, e);
			resetSegments();
		}

		function resetSegments() {
			vm.segments = {};
		}
	}
})();
