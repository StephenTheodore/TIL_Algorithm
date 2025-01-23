using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] points, int[,] routes)
    {
        LogisticsCenter logisticsCenter = new LogisticsCenter();

        for (int beaconIndex = 0; beaconIndex < points.GetLength(0); beaconIndex++)
        {
            List<int> location = new List<int>();
            for (int locationIndex = 0; locationIndex < points.GetLength(1); locationIndex++)
                location.Add(points[beaconIndex, locationIndex]);

            logisticsCenter.AddBeacon(beaconIndex + 1, location.ToArray());
        }
        for (int robotIndex = 0; robotIndex < routes.GetLength(0); robotIndex++)
        {
            List<int> route = new List<int>();
            for (int routeIndex = 0; routeIndex < routes.GetLength(1); routeIndex++)
                route.Add(routes[robotIndex, routeIndex]);

            logisticsCenter.AddTransferRobot(robotIndex + 1, route.ToArray());
        }

        logisticsCenter.StartSimulation();
        return logisticsCenter.AccidientCount;
    }
}

public class TransferRobot
{
    private int _posR;
    private int _posC;
    private readonly Queue<Beacon> _routes = new Queue<Beacon>();

    public int Id { get; private set; }
    public (int r, int c) Position => (_posR, _posC);
    public Beacon Destination => _routes.Peek();
    public bool IsJobFinished => _routes.Count == 0;

    public TransferRobot(int id, IEnumerable<Beacon> beacons)
    {
        Id = id;
        _posR = beacons.First().Location.r;
        _posC = beacons.First().Location.c;

        foreach (var beacon in beacons)
            _routes.Enqueue(beacon);
    }

    public void MovePosition()
    {
        if (IsJobFinished)
            return;

        if (_posR < Destination.Location.r)
            _posR++;
        else if (_posR > Destination.Location.r)
            _posR--;
        else if (_posC < Destination.Location.c)
            _posC++;
        else if (_posC > Destination.Location.c)
            _posC--;
    }

    public void CheckArrival()
    {
        if (Position.r == Destination.Location.r && 
            Position.c == Destination.Location.c)
            _routes.Dequeue();
    }
}

public class Beacon
{
    public int Id { get; private set; }
    public (int r, int c) Location { get; private set; }

    public Beacon(int id, int[] location)
    {
        Id = id;
        if (location.Length >= 2)
            Location = (location[0], location[1]);
    }
}

public class LogisticsCenter
{
    private readonly List<Beacon> _beacons = new List<Beacon>();
    private readonly List<TransferRobot> _transferRobots = new List<TransferRobot>();

    public int AccidientCount { get; private set; } = 0;

    public void AddBeacon(int id, int[] location) => _beacons.Add(new Beacon(id, location));

    public void AddTransferRobot(int id, int[] route)
    {
        var beaconRoutes = route.Select(routeId => _beacons.First(beacon => beacon.Id == routeId));
        _transferRobots.Add(new TransferRobot(id, beaconRoutes));
    }

    public void StartSimulation()
    {
        while (_transferRobots.Any(robot => !robot.IsJobFinished))
            MoveAllUnitOnce();
    }

    public void MoveAllUnitOnce()
    {
        var robots = _transferRobots.Where(robot => !robot.IsJobFinished);
        foreach (TransferRobot robot in robots)
            robot.MovePosition();

        CheckCollisons();

        foreach (TransferRobot robot in robots)
            robot.CheckArrival();
    }

    public void CheckCollisons()
    {
        var collisionCount = _transferRobots
            .Where(robot => !robot.IsJobFinished)
            .GroupBy(robot => robot.Position)
            .Count(group => group.Count() > 1);

        AccidientCount += collisionCount;
    }
}