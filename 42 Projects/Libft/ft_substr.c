/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_substr.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:59:37 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 16:03:51 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_substr(const char *s, unsigned int start, size_t len)
{
	size_t		i;
	char		*temp;

	i = 0;
	if (s == 0)
		return (NULL);
	if (start >= ft_strlen(s))
		return (ft_strdup(""));
	if (ft_strlen(s) < len)
	{
		if (!(temp = (char *)malloc(sizeof(char)
						* (ft_strlen(s) + 1))))
			return (NULL);
	}
	else if (!(temp = (char *)malloc(sizeof(char) * (len + 1))))
		return (NULL);
	while (s[i] && i < len)
	{
		temp[i] = s[start];
		i++;
		start++;
	}
	temp[i] = '\0';
	return (temp);
}
