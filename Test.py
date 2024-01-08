f = int(input())
fx = [int(input()) for i in range(f+1)]
g = int(input())
gx = [int(input()) for i in range(g+1)]
result = [0 for i in range(f+g+1)]
for i in range(f+1):
	for j in range(g+1):
		result[i+j] += (fx[i]*gx[j])
for i in range(len(result)):
	v = f+g
	print(f'{"+"+str(result[i]) if result[i] > 0 and i  else result[i]}v^{len(result)-i}',end = '')  