import heapq

def solution(scovilles, K):
    heapq.heapify(scovilles)
    
    mixCount = 0
    while len(scovilles) > 1 and scovilles[0] < K:
        heapq.heappush(scovilles, heapq.heappop(scovilles) + heapq.heappop(scovilles)*2)
        mixCount += 1
    
    if (scovilles[0] >= K):
        return mixCount
    else:
        return -1