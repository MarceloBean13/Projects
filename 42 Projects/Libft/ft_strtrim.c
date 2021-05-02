/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strtrim.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:57:43 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:59:22 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

int		sefunca(char c, const char *set)
{
	int	i;

	i = 0;
	while (set[i])
	{
		if (c == set[i])
			return (0);
		i++;
	}
	return (1);
}

int		ft_size(const char *s1, const char *set)
{
	size_t	i;
	size_t	cnt;

	i = ft_strlen(s1) - 1;
	cnt = 0;
	while (sefunca(s1[cnt], set) == 0)
		cnt++;
	if (cnt == ft_strlen(s1))
		return (-1);
	while (sefunca(s1[i], set) == 0)
	{
		i--;
		cnt++;
	}
	return (cnt);
}

char	*ft_strtrim(const char *s1, const char *set)
{
	size_t	cnt;
	size_t	i;
	size_t	len;
	char	*temp;

	cnt = 0;
	i = 0;
	if (!s1 && set)
		return (NULL);
	if (s1 && !set)
		return (ft_strdup(s1));
	if (!s1 && !set)
		return (NULL);
	len = ft_strlen(s1) - ft_size(s1, set);
	if (!(temp = (char *)malloc(sizeof(char) * len + 1)))
		return (NULL);
	if (ft_size(s1, set) == -1)
		len = 0;
	while (sefunca(s1[cnt], set) == 0)
		cnt++;
	while (i < len)
		temp[i++] = s1[cnt++];
	temp[i] = '\0';
	return (temp);
}
