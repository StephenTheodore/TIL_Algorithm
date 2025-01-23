using System;

public class Solution
{
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        int position = pos.TimeToSecond();
        int videoLength = video_len.TimeToSecond();
        int opStartPosition = op_start.TimeToSecond();
        int opEndPosition = op_end.TimeToSecond();

        var mediaPlayer = new MediaPlayer();
        var video = new Video(position, videoLength, opStartPosition, opEndPosition);
        
        mediaPlayer.InputVideo(video);
        foreach (var command in commands)
        {
            if (command == "next")
                mediaPlayer.SkipForward(10);
            else if (command == "prev")
                mediaPlayer.SkipBackward(10);
            
            Console.WriteLine(video.Position.SecondToTime());
        }
        mediaPlayer.OutputVideo();
        
        return video.Position.SecondToTime();
    }
}

public class MediaPlayer
{
    public Video CurrentVideo { get; private set; }
    
    public Action<int> OnForwardCommand;
    public Action<int> OnBackwardCommand;
    
    public void SkipForward(int second) => OnForwardCommand?.Invoke(second);
    
    public void SkipBackward(int second) => OnBackwardCommand?.Invoke(second);
    
    public void InputVideo(Video newVideo)
    {
        if (CurrentVideo is Video)
            OutputVideo();
        
        CurrentVideo = newVideo;
        OnForwardCommand += newVideo.MoveToNext;
        OnBackwardCommand += newVideo.MoveToPrev;
    }
    
    public void OutputVideo()
    {
        if (CurrentVideo is Video)
        {
            OnForwardCommand -= CurrentVideo.MoveToNext;
            OnBackwardCommand -= CurrentVideo.MoveToPrev;
            CurrentVideo = null;
        }
    }
}

public class Video
{
    private readonly int _length;
    private readonly int _opStartPosition;
    private readonly int _opEndPosition;
    
    public int Position { get; private set; }
    
    public Video(int position, int length, int opStartPosition, int opEndPosition)
    {
        Position = position;
        _length = length;
        _opStartPosition = opStartPosition;
        _opEndPosition = opEndPosition;
    }
    
    public void MoveToNext(int sec)
    {
        SkipOpening();
        Position = Math.Min(_length, Position + sec);
        SkipOpening();
    }
    
    public void MoveToPrev(int sec)
    {
        SkipOpening();
        Position = Math.Max(0, Position - sec);
        SkipOpening();
    }
    
    private void SkipOpening()
    {   
        if (_opStartPosition <= Position && Position <= _opEndPosition)
        {
            Console.WriteLine("T");
            Position = _opEndPosition;
        }
    }
}

public static class Utilities
{
    public static int TimeToSecond(this string timeString)
    {
        if (timeString.Contains(":") == false)
            return 0;
        
        string[] splitedString = timeString.Split(":");
        
        int minute = Convert.ToInt32(splitedString[0]);
        int second = Convert.ToInt32(splitedString[1]);
        
        return minute * 60 + second;
    }
    
    public static string SecondToTime(this int totalSecond)
    {
        int second = totalSecond % 60;
        int minute = (totalSecond - second) / 60;
        return $"{minute:D2}:{second:D2}";
    }
}