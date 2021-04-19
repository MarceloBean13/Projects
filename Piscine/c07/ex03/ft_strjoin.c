/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strjoin.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/09 13:04:38 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/10 09:29:31 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>

int		strcont(char *str1)
{
	int i;

	i = 0;
	while (str1[i] != '\0')
		i++;
	return (i);
}

char	*strgcopy(char *dest, char *src)
{
	int i;

	i = 0;
	while (src[i] != '\0')
	{
		dest[i] = src[i];
		i++;
	}
	dest[i] = '\0';
	return (dest);
}

int		ttlength(char **stgs, int size, int length)
{
	int i;
	int t_length;

	i = 0;
	t_length = 0;
	while (i < size)
	{
		t_length += strcont(stgs[i]);
		t_length += length;
		i++;
	}
	t_length -= length;
	return (t_length);
}

char	*ft_strjoin(int size, char **strs, char *sep)
{
	int		f_length;
	int		i;
	char	*head;
	char	*str;

	if (size == 0)
		return ((char *)malloc(sizeof(char)));
	f_length = ttlength(strs, size, strcont(sep));
	if (!(str = (char *)malloc((f_length + 1) * sizeof(char))))
		return (0);
	head = str;
	i = 0;
	while (i < size)
	{
		strgcopy(head, strs[i]);
		head += strcont(strs[i]);
		if (i < size - 1)
		{
			strgcopy(head, sep);
			head += strcont(sep);
		}
		i++;
	}
	*head = '\0';
	return (str);
}
