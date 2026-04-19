#include<iostream>
using namespace std;

void DFS(int y, int x);

int dy[4] = { 1, -1, 0, 0 };
int dx[4] = { 0, 0, 1, -1 };
int testcase, M, N, num, x, y;
int board[51][51];
bool visited[51][51];
int main()
{
	cin >> testcase;
	while (testcase--)
	{
		fill(visited[0], visited[0] + 51 * 51, 0);
		fill(board[0], board[0] + 51 * 51, 0);
		int cnt = 0;
		cin >> M >> N >> num;
		for (int i = 0; i < num; i++)
		{
			cin >> x >> y;
			board[y][x] = 1;
		}
		for (int i = 0; i < N; i++) // i 행좌표 
		{
			for (int j = 0; j < M; j++)
			{
				if (board[i][j] == 1 && !visited[i][j])
				{
					DFS(i, j);
					cnt++;
				}
			}
		}
		cout << cnt << '\n';
	}

	
}

void DFS(int y, int x)
{
	visited[y][x] = true;
	for (int i = 0; i < 4; i++)
	{
		int ny = y + dy[i];
		int nx = x + dx[i];
		if (nx >= M || ny >= N || nx < 0 || ny < 0) continue;
		if (board[ny][nx] == 1 && !visited[ny][nx])
		{
			DFS(ny, nx);
		}
	}
	return;
}
