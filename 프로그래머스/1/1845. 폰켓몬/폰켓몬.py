def solution(nums):
    species = set(nums);
    return min(len(species), len(nums) // 2)