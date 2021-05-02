/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_split.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:44:27 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:44:43 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

static int	ft_wds(const char *str, char c)
{
	int	cnt;
	int	i;

	cnt = 0;
	i = 0;
	while (str[i])
	{
		while (str[i] && (str[i] == c))
			i++;
		if (str[i] && str[i] != c)
		{
			cnt++;
			while (str[i] && str[i] != c)
				i++;
		}
	}
	return (cnt);
}

static char	*mem_wrd(const char *str, char c)
{
	char	*temp;
	int		i;

	i = 0;
	while (str[i] && str[i] != c)
		i++;
	if (!(temp = (char *)malloc(sizeof(char) * (i + 1))))
		return (NULL);
	i = 0;
	while (str[i] && str[i] != c)
	{
		temp[i] = str[i];
		i++;
	}
	temp[i] = '\0';
	return (temp);
}

char		**ft_split(const char *s, char c)
{
	char	**temp;
	int		x;
	int		y;

	if (!s)
		return (NULL);
	if (!(temp = (char **)malloc(sizeof(char *) * (ft_wds(s, c) + 1))))
		return (NULL);
	x = 0;
	y = 0;
	while (s[x])
	{
		while (s[x] && (s[x] == c))
			x++;
		if (s[x] && s[x] != c)
		{
			temp[y] = mem_wrd(s + x, c);
			y++;
			while (s[x] && s[x] != c)
				x++;
		}
	}
	temp[y] = NULL;
	return (temp);
}
