def solution(arr):
    answer = []
    
    if (len(arr) > 0):
        answer.append(arr[0])
    
    for index in range(len(arr) - 1):
        if (arr[index] != arr[index + 1]):
            answer.append(arr[index + 1])
            
    return answer