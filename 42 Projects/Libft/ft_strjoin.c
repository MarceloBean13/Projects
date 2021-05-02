/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strjoin.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:48:18 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:54:32 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*connect(const char *temp1, const char *temp2, char *c)
{
	int a;
	int b;

	a = 0;
	b = 0;
	while (temp1[a])
	{
		c[a] = temp1[a];
		a++;
	}
	while (temp2[b])
	{
		c[a + b] = temp2[b];
		b++;
	}
	c[a + b] = '\0';
	return (c);
}

char	*ft_strjoin(const char *s1, const char *s2)
{
	char	*temp;
	int		i;

	i = 0;
	if (!s1 && s2)
		return (ft_strdup(s2));
	if (s1 && !s2)
		return (ft_strdup(s1));
	if (!s1 && !s2)
		return (NULL);
	i = ft_strlen(s1) + ft_strlen(s2);
	if ((!(temp = (char *)malloc(sizeof(char) * i + 1))))
		return (NULL);
	temp = connect(s1, s2, temp);
	return (temp);
}
